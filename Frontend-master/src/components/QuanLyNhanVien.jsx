import React, { Component } from 'react';

class QuanLyNhanVien extends Component {
    constructor(props) {
        super(props);
        this.state = {
            trangThai: true
        }
    }
    trangThaiSua = () => {
        if (this.state.trangThai) {
            this.setState({
                trangThai: !this.state.trangThai
            });
        }
    }
    trangThaiThemMoi = () => {
        if (!this.state.trangThai) {
            this.setState({
                trangThai: !this.state.trangThai
            });
        }
    }
    hienThiForm = () => {
        if (this.state.trangThai === true) {
            return (<div className="col-3">
                <div className="card text-center">
                    <div className="card-header">
                        <p className="disabled">Thêm mới</p>
                    </div>
                    <div className="card-body">
                        <div className="form-group">
                            <div className="form-group">
                                <p style={{ textAlign: 'left' }}>Mã nhân viên</p>
                                <input type="text" className="form-control" name id aria-describedby="helpId" placeholder="Mã nhân viên" />
                                <p style={{ textAlign: 'left' }}>Tên nhân viên</p>
                                <input type="text" className="form-control" name id aria-describedby="helpId" placeholder="Tên nhân viên" />
                                <p style={{ textAlign: 'left' }}>Chức vụ</p>
                                <input type="text" className="form-control" name id aria-describedby="helpId" placeholder="Chức vụ" />
                                <p style={{ textAlign: 'left' }}>Phòng ban</p>
                                <input type="text" className="form-control" name id aria-describedby="helpId" placeholder="Phòng ban" />
                                {/* <p style="text-align: left;">Quyền</p>
                  <select class="form-select form-control" aria-label="Default select example">
                      <option selected>Chọn quyền</option>
                      <option value="1">One</option>
                      <option value="2">Two</option>
                      <option value="3">Three</option>
                    </select>
              </div> */}
                                <input type="submit" className="btn btn-primary btn-block mt-2" value="Thêm mới" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>);
        }
        else {
            return (<div className="col-3">
                <div className="card text-center">
                    <div className="card-header">
                        <p className="disabled">Sửa</p>
                    </div>
                    <div className="card-body">
                        <div className="form-group">
                            <div className="form-group">
                                <p style={{ textAlign: 'left' }}>Mã nhân viên</p>
                                <input type="text" className="form-control" name id aria-describedby="helpId" placeholder="Mã nhân viên" />
                                <p style={{ textAlign: 'left' }}>Tên nhân viên</p>
                                <input type="text" className="form-control" name id aria-describedby="helpId" placeholder="Tên nhân viên" />
                                <p style={{ textAlign: 'left' }}>Chức vụ</p>
                                <input type="text" className="form-control" name id aria-describedby="helpId" placeholder="Chức vụ" />
                                <p style={{ textAlign: 'left' }}>Phòng ban</p>
                                <input type="text" className="form-control" name id aria-describedby="helpId" placeholder="Phòng ban" />
                                {/* <p style="text-align: left;">Quyền</p>
              <select class="form-select form-control" aria-label="Default select example">
                  <option selected>Chọn quyền</option>
                  <option value="1">One</option>
                  <option value="2">Two</option>
                  <option value="3">Three</option>
                </select>
          </div> */}
                                <input type="submit" className="btn btn-primary btn-block mt-2" value="Sửa" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>);
        }
    }
    render() {

        return (
            <div className="col-9">
                <h1>Chức năng Quản lý nhân viên</h1>
                <div className="btn-group">
                    <div className="form-group">
                        <input type="text" name id className="form-control" placeholder="Nhập tên" />
                    </div>
                    <div className="btn btn-primary ml-1">Tìm kiếm</div>
                    <div className="btn btn-primary themmoi mt-1" onClick={() => this.trangThaiThemMoi()}>Thêm mới</div>

                </div>
                <div className="row">
                    <div className="col-9">
                        <table className="table table-striped table-hover">
                            <thead>
                                <tr>
                                    <th>STT</th>
                                    <th>Mã nhân viên</th>
                                    <th>Tên nhân viên</th>
                                    <th>Cấp bậc</th>
                                    <th>Phòng ban</th>
                                    {/* <th>Quyền</th> */}
                                    <th>Thao tác</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>1</td>
                                    <td>ABC</td>
                                    <td>hoang</td>
                                    <td>Giáo viên</td>
                                    <td>Toán - Tin học</td>
                                    {/* <td>admin</td> */}
                                    <td>
                                        <div className="btn btn-warning btn-group" style={{ fontSize: "22px" }}>
                                            <div className="fa fa-edit" onClick={() => this.trangThaiSua()}>Sửa</div>
                                        </div>
                                        <div className="btn btn-danger btn-group ml-2" style={{ fontSize: "22px" }}>
                                            <div className="fa fa-edit">Xóa</div>
                                        </div>
                                    </td>
                                </tr>


                                {/* copy tr vào đây */}
                            </tbody>
                        </table>
                    </div>
                    {this.hienThiForm()}
                </div>

            </div>
        );
    }
}

export default QuanLyNhanVien;